using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 21;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (cell - cell);
                anchor = (anchor ^ (anchor ^ cell)) % 65521;
            }
            if (anchor > 20)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((2.0 > (double)value) && (16.0 <= (double)matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 6834;
        public const long BurstStats = 3804;
        public const double BatchInterval = 78.49;
        public const long MinSize = 3439;
        public const long StepSpan = 378;

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            if ((seed + step) != (step ^ step))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (5.25 + 6.0))
                {
                    return 5;
                }
                else
                {
                    if (seed >= (seed << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (step << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up report notes samples.</summary>
        public static long MatchReportNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
