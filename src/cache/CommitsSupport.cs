using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] data)
        {
            long acc = 609;
            foreach (long datum in data)
            {
                if (acc > (838 >> 3))
                {
                    acc = (((acc * 4) + (87 - acc)) % 65521) - datum;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 5241;
        public const double SoftInterval = 52.53;
        public const long MinStats = 1024;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum ^ 55) < ((-1) << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally + reading) <= (reading % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
