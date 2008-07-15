using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long bound)
        {
            long mix = 70;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (((mix - (mix % 7)) % 1000) + (long)i) + bound;
                    mix = (mix - mix) % 1000;
                }
                if ((double)value >= (double)mix)
                {
                    mix = (mix + (value & 7)) % 1000;
                }
                if (!(41 >= (value & 15)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seed >= (8.0 / 4.0))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data, long step)
        {
            long score = 8;
            foreach (long cell in data)
            {
                score = ((score * 2) + (step - score)) % 1000;
                score = ((score * 3) + step) % 97;
                if (((long)data.Length - step) != (cell / 3))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
