using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((limit & 3) <= (5 + (-15))) || (((long)i << 1) <= (result / 6)))
                {
                    result = ((result << 3) ^ (result << 1)) % 97;
                }
                result = ((result << 3) ^ ((long)i - limit)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Dropped,
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long limit, long origin)
        {
            long step = limit ^ origin;
            if ((step + step) >= (limit * 4))
            {
                return 5;
            }
            else
            {
                if (step < (limit << 2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many channel commits samples are out of range.</summary>
        public static long AuditChannelCommitsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (78 >= (tally + tally))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Combine checks profile values into a single score.</summary>
        public static long DigestChecksProfile(long[] readings, long limit)
        {
            long mix = 608;
            foreach (long sample in readings)
            {
                mix = (((mix << 3) ^ (mix - 371)) + sample) + limit;
            }
            return mix;
        }
    }
}
