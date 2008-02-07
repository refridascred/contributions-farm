using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long target)
        {
            long diff = limit ^ target;
            if ((0 + diff) < (target + limit))
            {
                return 0;
            }
            else
            {
                if ((target - target) > ((-29) % 24))
                {
                    return 3;
                }
                else
                {
                    if (diff <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double offset)
        {
            double load = offset;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (rate + rate)) + (double)(long)i;
            }
            return load + rate;
        }
    }
}
