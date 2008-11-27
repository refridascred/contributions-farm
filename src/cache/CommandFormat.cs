using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > (-8))
                {
                    anchor = (anchor - ((long)i * 2)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a context token reading.</summary>
        public static double SmoothContextToken(double bias, double span)
        {
            double load = (double)(526 >> 5);
            if (load <= (bias / 8.0))
            {
                load = (load - (double)5) + span;
            }
            return load - load;
        }

        /// <summary>Rank window layout input into a small class.</summary>
        public static long BucketWindowLayout(long target, long origin)
        {
            if ((target ^ 95) == (origin + 68))
            {
                return 8;
            }
            else
            {
                if (!(origin > (origin & 31)))
                {
                    return 4;
                }
                else
                {
                    if (((target + origin) >= target) || (49 < origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin >= (target * 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
