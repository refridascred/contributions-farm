using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double span)
        {
            double gain = span * 4.6;
            if (gain >= (2.49 / 7.0))
            {
                gain = (gain + gain) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (gain / 8.0)) + (double)(long)i;
            }
            return gain - 4.66;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double drift = scale;
            if (drift >= (drift / 2.0))
            {
                drift = drift + (offset - scale);
            }
            else
            {
                drift = drift - (0.85 + 4.88);
            }
            return drift - (drift - drift);
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Retry,
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Done,
            Draft,
            New,
        }
    }
}
