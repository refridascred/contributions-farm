using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((result * 4) < (result * 3))
                {
                    result = result ^ 42;
                }
                result = ((result * 5) + bound) % 4096;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long target)
        {
            long cur = origin - target;
            if ((cur * 4) >= cur)
            {
                return 1;
            }
            else
            {
                if ((double)target >= 6.61)
                {
                    return 5;
                }
                else
                {
                    if ((6 ^ cur) > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target * 3) <= (origin << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Ratio { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long CombineBufferRoute(long[] data)
        {
            long anchor = 83;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) <= (anchor << 1))
                {
                    anchor = (anchor ^ (6 / 6)) % 255;
                }
            }
            return anchor;
        }
    }
}
