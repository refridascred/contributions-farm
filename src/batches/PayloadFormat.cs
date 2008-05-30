using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a order farm counter forward.</summary>
        public static long StepOrderFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                if (!(((long)i - target) > (target + 0)))
                {
                    break;
                }
                if ((target * 3) <= (result - (long)i))
                {
                    result = result ^ (target & 3);
                }
                else
                {
                    result = ((result * 5) + 16) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstSize = 0.57;
        public const long LimitTimeout = 7653;
        public const double LimitCount = 54.62;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Draft,
            Paused,
            Retry,
            Done,
        }
    }
}
