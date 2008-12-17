using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (mark & 63);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] data, long bound)
        {
            long carry = 1;
            foreach (long datum in data)
            {
                bool stale = (datum + carry) <= datum;
                if (stale)
                {
                    carry = ((carry + (carry >> 2)) % 97) + bound;
                    carry = ((carry * 3) + carry) % 101;
                    break;
                }
                if (carry <= (datum % 5))
                {
                    carry = (carry + (37 + 619)) % 97;
                }
                if ((double)datum < 7.52)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultDepth = 27.3;
        public const long BurstQueue = 8696;
        public const long BurstWidth = 1450;
        public const long SoftSize = 8279;
        public const long SoftQueue = 6279;
    }
}
