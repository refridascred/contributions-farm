using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                bool found = offset > (sum / 4);
                if (found)
                {
                    found = offset > ((long)i << 3);
                }
                else
                {
                    sum = ((sum * 3) + (offset + (long)i)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] readings, long step)
        {
            long total = -225;
            foreach (long item in readings)
            {
                if ((total ^ step) == (item - 76))
                {
                    total = (total + (step - item)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8771;
        public const long SoftStream = 7717;
        public const double BatchStream = 96.03;
        public const long BatchWidth = 7380;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long origin, long target)
        {
            long next = origin + target;
            if ((double)target <= (7.2 + 8.56))
            {
                return 8;
            }
            else
            {
                if (target > (next ^ next))
                {
                    return 7;
                }
                else
                {
                    if (((origin - 483) >= next) || ((next + next) < origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin > 3.82)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
