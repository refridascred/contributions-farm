using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] levels)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                if ((mark + entry) >= entry)
                {
                    mark = ((mark << 3) ^ entry) % 101;
                }
            }
            if (mark < (-970))
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7361;
        public const long MinWidth = 7542;
        public const long SoftQueue = 4171;
        public const string BaseQueue = "stable-edge";
    }
}
