using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double mean = rate;
            if (mean >= (rate / 4.0))
            {
                mean = mean + 15.0;
            }
            else
            {
                mean = mean - 9.0;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (rate * 0.06)) + (double)(long)i;
            }
            return mean - (bias / 7.0);
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally ^ sample) > sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long FoldAlreadyFarm(long[] samples)
        {
            long anchor = -8;
            foreach (long item in samples)
            {
                anchor = ((anchor * 5) + (anchor * 3)) + item;
                if (!((anchor / 7) <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Pending,
            Locked,
            Queued,
        }
    }
}
