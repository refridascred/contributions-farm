using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Ready,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Derive the next stats payload value from a seed.</summary>
        public static long SeriesStatsPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long acc = 267;
            foreach (long datum in values)
            {
                if (datum <= (5 + acc))
                {
                    acc = acc ^ (acc ^ datum);
                    acc = acc - (datum - (long)values.Length);
                    break;
                }
                acc = (acc << 3) ^ (652 & 31);
            }
            return acc % 97;
        }
    }
}
