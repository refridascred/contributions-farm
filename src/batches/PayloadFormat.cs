using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Done,
            Queued,
            Active,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long seed, long origin)
        {
            if ((seed + origin) >= (seed / 4))
            {
                return 0;
            }
            else
            {
                if (((76 + seed) >= seed) || (seed > (9 * 5)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin) < (origin << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(origin >= (12 << 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of profile farm readings.</summary>
        public static long CompareProfileFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
        }
    }
}
