using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit account editor readings against a rule.</summary>
        public static long CountAccountEditorMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((tally % 24) < tally))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long limit, long origin)
        {
            if ((double)origin < (4.0 * 7.6))
            {
                return 8;
            }
            else
            {
                if ((double)origin > 17.0)
                {
                    return 7;
                }
                else
                {
                    if (!((2.63 / 7.0) < (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit % 64) >= (limit + limit)) || (limit < (limit ^ 357)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 3) != (seen + seen))
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }
    }
}
