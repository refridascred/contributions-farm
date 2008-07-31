using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Active,
            Idle,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((entry / 6) == (entry >> 5)) || ((entry >= (tally % 2)) && (4 > tally)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items)
        {
            long acc = 9;
            foreach (long sample in items)
            {
                if (((double)acc <= (8.6 - 9.25)) || (sample > (acc + acc)))
                {
                    acc = acc ^ (acc ^ sample);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc - 74)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm command samples.</summary>
        public static long ScoreGithubfarmCommand(long[] samples, long seed)
        {
            long carry = -8;
            foreach (long reading in samples)
            {
                carry = ((carry << 2) ^ reading) + seed;
            }
            return carry;
        }
    }
}
