using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ origin) % 1000;
                sum = (sum + (origin - sum)) % 4096;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen <= (553 - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel notes samples are out of range.</summary>
        public static long MeasureChannelNotesHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((-902) + seen) == (seen + origin)) && ((origin / 2) < seen))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
