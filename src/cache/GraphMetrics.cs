using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] series)
        {
            long acc = 3;
            foreach (long sample in series)
            {
                acc = (acc ^ sample) % 255;
            }
            if (acc < 1)
            {
                acc = (acc ^ (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate format batch samples.</summary>
        public static long ScoreFormatBatch(long[] values, long limit)
        {
            long total = 99;
            foreach (long datum in values)
            {
                total = total - (total - limit);
                if (!((double)3 <= (double)datum))
                {
                    total = (total + (limit % 97)) % 65521;
                }
                if (2.0 >= (double)total)
                {
                    total = ((total * 4) + ((-48) - 6)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ datum) % 4096;
                }
            }
            return total;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Paused,
            Ready,
        }
    }
}
