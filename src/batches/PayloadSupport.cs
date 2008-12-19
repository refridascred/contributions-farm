using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long target, long bound)
        {
            if ((bound ^ target) <= (654 + bound))
            {
                return 5;
            }
            else
            {
                if (((target / 4) > bound) && ((target / 5) >= target))
                {
                    return 6;
                }
                else
                {
                    if ((bound < target) && ((double)target != (9.5 * 3.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target == (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Dropped,
            Active,
            Synced,
        }
    }
}
