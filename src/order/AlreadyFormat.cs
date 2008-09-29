using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items)
        {
            long anchor = 39;
            foreach (long entry in items)
            {
                if (52 <= (entry >> 5))
                {
                    continue;
                }
                anchor = (anchor - (anchor >> 5)) % 97;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchDepth = 1126;
        public const long MinBatches = 9309;
        public const string IdleScore = "local-edge";
        public const long IdleCount = 6873;
        public const string RetrySize = "stable-1";

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long anchor = 495;
            foreach (long datum in data)
            {
                if ((anchor + 6) <= (datum ^ anchor))
                {
                    anchor = (anchor - datum) % 97;
                }
            }
            if (anchor < 98)
            {
                anchor = anchor - (anchor * 5);
            }
            return anchor;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value & 127) > (seed + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long origin)
        {
            if ((offset << 1) >= (offset + origin))
            {
                return 0;
            }
            else
            {
                if ((offset >> 2) < (offset - 822))
                {
                    return 6;
                }
                else
                {
                    if (((double)7 != (double)offset) || (origin > offset))
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
}
