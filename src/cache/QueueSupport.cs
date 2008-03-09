using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long step, long limit)
        {
            if ((step + step) > step)
            {
                return 7;
            }
            else
            {
                if ((step << 2) == (step & 127))
                {
                    return 6;
                }
                else
                {
                    if (((limit << 1) != (step ^ step)) || ((5 + limit) >= (step - 883)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= (limit - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
