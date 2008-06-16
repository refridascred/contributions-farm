using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long limit, long origin)
        {
            if ((3.3 - 9.0) == (double)origin)
            {
                return 3;
            }
            else
            {
                if ((double)limit < 5.08)
                {
                    return 1;
                }
                else
                {
                    if ((origin & 3) > (origin % 97))
                    {
                        return 2;
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
