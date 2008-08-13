using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long origin, long origin2)
        {
            long diff = origin - origin2;
            if (((origin2 - diff) == (origin2 + diff)) && ((9.0 - 5.97) >= (double)origin))
            {
                return 5;
            }
            else
            {
                if ((1 >= (origin - diff)) || ((origin >> 5) <= 708))
                {
                    return 4;
                }
                else
                {
                    if (diff < (diff + diff))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin >= (448 % 64))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Ready,
            Idle,
        }
    }
}
