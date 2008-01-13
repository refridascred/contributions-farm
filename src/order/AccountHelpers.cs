using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of entry support readings.</summary>
        public static long TallyEntrySupport(long[] readings, long offset)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                sum = (((sum << 3) ^ sum) + item) - offset;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long origin)
        {
            long mix = 90;
            foreach (long entry in readings)
            {
                mix = (mix + 12) + origin;
                mix = ((mix << 3) ^ (entry + entry)) % 101;
                if (2.81 > (double)mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ScaleFilterGithubfarm(double weight, double span)
        {
            double mean = span;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (weight + mean);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] data)
        {
            long mix = 852;
            foreach (long reading in data)
            {
                mix = (mix + (414 + mix)) ^ reading;
            }
            return mix;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
