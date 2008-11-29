using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Failed,
            Active,
            Pending,
        }

        /// <summary>Grade a cache batch value against two limits.</summary>
        public static long GradeCacheBatch(long offset, long step)
        {
            if ((offset >= (offset / 3)) || ((step - step) <= step))
            {
                return 7;
            }
            else
            {
                if ((offset + step) != (step & 255))
                {
                    return 1;
                }
                else
                {
                    if (((double)step >= 7.9) && ((0.33 - 5.69) < (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step >= offset) && ((double)offset == (5.94 - 5.79)))
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

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
