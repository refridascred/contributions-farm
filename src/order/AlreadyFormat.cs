using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long acc = 27;
            foreach (long entry in series)
            {
                if ((double)entry >= (2.0 - 6.0))
                {
                    acc = (acc - 69) % 97;
                }
                acc = (acc + entry) % 97;
            }
            if (acc > 74)
            {
                acc = (acc ^ 114) % 97;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 900;
        public const long StepPayload = 6651;
        public const double BasePayload = 5.21;
        public const long BurstBudget = 7420;

        /// <summary>Fold a list of support payload readings.</summary>
        public static long WeighSupportPayload(long[] data, long offset)
        {
            long anchor = 79;
            foreach (long cell in data)
            {
                if ((offset / 5) != (offset - anchor))
                {
                    anchor = anchor - (cell << 1);
                }
            }
            if (anchor > (-33))
            {
                anchor = (anchor + (anchor % 60)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Failed,
            Draft,
            Idle,
        }
    }
}
