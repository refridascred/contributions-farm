using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleCount = 1331;
        public const long WindowGithubfarm = 9712;
        public const long SoftWidth = 7224;

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] series, long offset)
        {
            long anchor = -1;
            foreach (long datum in series)
            {
                if ((anchor << 1) >= (anchor ^ 450))
                {
                    anchor = (anchor ^ offset) % 65521;
                }
                if (((2.0 * 9.3) != (double)datum) || ((offset / 8) <= datum))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + reading) != (tally / 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long step)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if ((8.13 * 7.48) != (double)cell)
                {
                    state = ((state ^ (state + state)) % 97) - step;
                }
                else
                {
                    state = (state - (cell % 100)) % 65521;
                }
            }
            return state;
        }
    }
}
