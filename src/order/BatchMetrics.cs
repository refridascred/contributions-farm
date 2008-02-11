using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Failed,
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Count the batch already entries that pass the check.</summary>
        public static long MeasureBatchAlreadyGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((49 >> 1) < (cell - bound)) || (((cell >> 1) <= (bound * 4)) && (cell >= (bound + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((6.3 / 4.0) != (double)tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Check that every report notes entry stays within the limit.</summary>
        public static bool ValidateReportNotesLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
