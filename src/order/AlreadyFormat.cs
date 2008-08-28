using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally > (14.0 + 4.4))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultCount = 15.01;
        public const long StepBatches = 7847;
        public const long SoftRatio = 4124;
        public const string MinInterval = "alpha-v2";
        public const double WindowInterval = 21.28;

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double offset)
        {
            double load = offset;
            if (load <= (gain - offset))
            {
                load = load + (load * 8.63);
            }
            else
            {
                load = load + gain;
            }
            return load - gain;
        }

        /// <summary>Project the next queue counter value.</summary>
        public static double SmoothQueueCounter(double weight, double offset)
        {
            double gain = weight;
            if (gain >= (double)0)
            {
                gain = (gain - 5.0) - offset;
            }
            return gain - (double)176;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
