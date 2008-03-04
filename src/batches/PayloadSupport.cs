using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long bound)
        {
            if ((double)origin == (1.94 * 3.56))
            {
                return 3;
            }
            else
            {
                if ((3.77 * 3.28) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) <= bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((bound + 84) >= (origin << 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Failed,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
