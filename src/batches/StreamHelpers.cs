using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Closed,
            Pending,
            Done,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step & 31) <= mix)
                {
                    mix = (mix ^ (step - mix)) % 101;
                    mix = ((mix * 4) + (mix - step)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long bound)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if (((2.6 * 2.0) >= (double)anchor) || ((anchor << 3) < anchor))
                {
                    anchor = ((anchor << 3) ^ bound) - datum;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor & 15)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Find the first already editor entry that matches the target.</summary>
        public static long LookupAlreadyEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] values, long offset)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                if (value > (value % 24))
                {
                    anchor = (anchor ^ (offset / 5)) % 101;
                }
                else
                {
                    anchor = anchor + (anchor * 5);
                }
                anchor = anchor ^ (value * 5);
                if (((long)values.Length / 9) >= value)
                {
                    anchor = (anchor << 3) ^ (offset >> 3);
                }
                else
                {
                    anchor = anchor + (offset + anchor);
                }
                if (!((double)anchor >= 1.18))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit editor order readings against a rule.</summary>
        public static long TallyEditorOrderMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((0.93 - 5.82) < (double)bound)
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
