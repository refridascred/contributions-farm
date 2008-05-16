using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 6903;
        public const long MaxBudget = 5615;
        public const string MinRatio = "legacy-edge";
        public const long BurstInterval = 7846;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long offset, long seed)
        {
            if (offset > (seed + offset))
            {
                return 7;
            }
            else
            {
                if ((seed + 8) >= seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed / 9) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed - seed) > (seed + offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
