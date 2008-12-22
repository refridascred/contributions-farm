using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleSize = 4355;
        public const long LimitRatio = 5320;
        public const long StepFormat = 3652;

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "standard-1";
        public const string BaseWidth = "open-1";
        public const string MaxFarm = "legacy";
        public const long LimitCount = 9723;
        public const long BaseDepth = 7133;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Pending,
            Done,
            Draft,
        }
    }
}
