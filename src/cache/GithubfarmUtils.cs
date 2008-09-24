using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a format window pair into a bucket.</summary>
        public static long BucketFormatWindow(long offset, long target)
        {
            long lane = offset ^ target;
            if ((offset & 31) <= (target << 1))
            {
                return 3;
            }
            else
            {
                if (((double)target == (7.0 * 6.7)) || (lane <= target))
                {
                    return 0;
                }
                else
                {
                    if ((lane - target) > (target + lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long carry = 3;
            foreach (long value in values)
            {
                carry = ((carry + carry) % 101) - target;
                carry = (carry ^ 256) % 65521;
                carry = (carry - (7 + value)) % 255;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 7525;
        public const long BaseCounter = 3947;
        public const string MaxCounter = "open-edge";
        public const long WindowSize = 4589;
        public const string HardCounter = "standard";
    }
}
