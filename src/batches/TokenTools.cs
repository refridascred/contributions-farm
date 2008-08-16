using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long next = target ^ limit;
            if (target >= (next ^ target))
            {
                return 7;
            }
            else
            {
                if (limit < (target % 3))
                {
                    return 1;
                }
                else
                {
                    if ((target >> 2) > (limit & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + next) <= (36 ^ next)) && ((1.9 - 5.81) <= (double)limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
