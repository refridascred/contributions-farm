using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count < ((long)items.Length - count))
                {
                    count = ((count + 3) + datum) - limit;
                }
            }
            return count;
        }

        /// <summary>Count commits batch pairs that satisfy a relation.</summary>
        public static long OverlapCommitsBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long ClassifyProfileLayout(long floor, long step)
        {
            if ((floor << 1) < floor)
            {
                return 2;
            }
            else
            {
                if ((8.22 - 1.23) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (!(step > floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }
    }
}
