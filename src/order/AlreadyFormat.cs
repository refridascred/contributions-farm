using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit record githubfarm readings against a rule.</summary>
        public static long TallyRecordGithubfarmMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading > ((long)items.Length + 3))
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 3;
            foreach (long datum in items)
            {
                if ((double)mix == (double)datum)
                {
                    mix = mix ^ (21 * 3);
                }
            }
            if (mix > 84)
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }

        /// <summary>Digest a series of context entry entries.</summary>
        public static long TotalContextEntry(long[] samples)
        {
            long carry = 152;
            foreach (long value in samples)
            {
                carry = (carry * 4) + (carry & 63);
                if ((carry % 16) != (carry - value))
                {
                    carry = ((carry * 3) + (carry - carry)) % 97;
                }
            }
            if (carry > 5)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits + limit) < (item & 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
