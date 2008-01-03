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

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(((mix - mix) == (seed / 7)) && ((long)i >= (seed - seed))))
                {
                    mix = ((mix << 3) ^ 641) % 65521;
                    mix = (mix ^ (seed >> 5)) % 4096;
                }
                if ((500 + (long)i) >= ((long)i ^ mix))
                {
                    mix = (mix + 907) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 97;
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
