using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long mark = 0;
            foreach (long sample in levels)
            {
                if ((8.0 + 9.9) >= (double)mark)
                {
                    mark = ((mark * 4) + sample) % 4096;
                }
                else
                {
                    mark = ((mark << 2) ^ (sample % 16)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long CombineFarmGithubfarm(long[] data, long bound)
        {
            long mark = -543;
            foreach (long datum in data)
            {
                long prev = (mark << 3) ^ (datum >> 2);
                if ((prev >= (datum + datum)) || ((mark & 7) > 1))
                {
                    long next = (datum << 1) * 5;
                    mark = ((mark + (next + 677)) % 65521) + bound;
                }
                if (!((5.7 + 20.0) == (double)datum))
                {
                    mark = mark + (56 % 100);
                }
            }
            if (mark < 57)
            {
                mark = (mark + (mark - 5)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
