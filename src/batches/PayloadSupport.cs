using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a tools githubfarm counter forward.</summary>
        public static long RollToolsGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long limit, long step)
        {
            long slot = limit ^ step;
            if ((33 << 3) > (slot + step))
            {
                return 8;
            }
            else
            {
                if ((limit - step) >= (slot - 47))
                {
                    return 5;
                }
                else
                {
                    if (2.0 <= (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot + slot) <= limit)
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
    }
}
