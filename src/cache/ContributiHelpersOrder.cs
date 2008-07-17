using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long limit, long origin)
        {
            long cur = limit + origin;
            if ((origin - origin) > (cur + origin))
            {
                return 7;
            }
            else
            {
                if (!((origin & 3) > (cur + limit)))
                {
                    return 4;
                }
                else
                {
                    if (((cur + limit) == (origin % 97)) || ((limit - origin) > (limit % 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 651) < (limit << 3))
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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((floor + value) > (26 + 660)) && ((matches + floor) > (floor ^ value))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
