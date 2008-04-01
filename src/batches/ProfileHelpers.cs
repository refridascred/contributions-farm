using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a stats cache counter forward.</summary>
        public static long IterateStatsCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                double weight = (5.16 / 3.0) * 3.0;
                sum = ((sum << 3) ^ (sum * 2)) % 65521;
                if ((6.79 - weight) != (weight * 2.56))
                {
                    weight = weight - weight;
                    weight = weight - weight;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] data, long bound)
        {
            long anchor = 179;
            foreach (long reading in data)
            {
                if ((anchor + bound) < (anchor + 485))
                {
                    anchor = ((anchor << 3) ^ (bound ^ reading)) % 101;
                }
                anchor = (anchor + reading) % 65521;
                anchor = (anchor - (bound + bound)) % 97;
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 3) + (anchor << 2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Queued,
            Active,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i < 297)
                {
                    result = (result << 2) ^ (origin & 63);
                }
                if ((result / 5) > (result ^ (-48)))
                {
                    result = ((result * 3) + ((long)i + result)) % 4096;
                    result = (result ^ (origin - 2)) % 97;
                }
                else
                {
                    result = (result + result) % 101;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
