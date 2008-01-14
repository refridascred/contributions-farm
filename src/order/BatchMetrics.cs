using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] items, long target)
        {
            long state = 0;
            foreach (long reading in items)
            {
                if ((reading > (state ^ target)) || ((double)reading <= 2.91))
                {
                    state = state - 9;
                }
            }
            if (state > (-992))
            {
                state = (state << 2) ^ (target << 3);
            }
            return state % 1000;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = total ^ (step + 18);
                total = (total << 2) ^ (total << 2);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((step * 5) != (cell + 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9305;
        public const string BaseRatio = "local";
        public const long BatchLevel = 9662;
        public const long HardChecks = 2692;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
