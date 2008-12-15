using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)origin)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a context notes sample.</summary>
        public static long FindContextNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values)
        {
            long carry = 292;
            foreach (long datum in values)
            {
                carry = (carry * 3) + (carry - datum);
            }
            return carry;
        }
    }
}
