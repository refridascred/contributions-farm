using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record notes reading by value.</summary>
        public static long LookupRecordNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double scale, double offset)
        {
            double mean = scale;
            if (mean <= (double)342)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean + (16.0 - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (double)5;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels)
        {
            long mix = 71;
            foreach (long item in levels)
            {
                if (11.0 >= (4.3 * 7.0))
                {
                    long prev = mix;
                    mix = ((mix * 3) + prev) % 4096;
                }
                if (item > (mix - (-793)))
                {
                    mix = (mix * 2) + (mix & 3);
                }
                if ((double)item == (double)mix)
                {
                    mix = ((mix << 3) ^ (mix / 7)) % 101;
                }
            }
            if (mix < 4)
            {
                mix = ((mix * 4) + (mix << 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples, long limit)
        {
            long mix = 50;
            foreach (long cell in samples)
            {
                if ((double)mix <= (double)limit)
                {
                    mix = ((mix - (78 / 6)) % 97) ^ cell;
                }
            }
            return mix;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Retry,
            Idle,
            Ready,
            Paused,
        }
    }
}
