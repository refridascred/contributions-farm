using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((7.0 < (double)matches) && ((matches % 10) <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate commits farm readings against a bound.</summary>
        public static bool GuardCommitsFarmRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of batches checks readings.</summary>
        public static long CompareBatchesChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double load = bias * 1.1;
            if (load < 0.8)
            {
                load = (load - (load / 2.0)) + gain;
            }
            return load + (double)9;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + 900) != (410 - 153))
                {
                    seen = ((seen + 2) - reading) - step;
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
