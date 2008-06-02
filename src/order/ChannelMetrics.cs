using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Draft,
            Active,
            New,
            Pending,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Accumulate editor format samples.</summary>
        public static long DigestEditorFormat(long[] values)
        {
            long mix = 183;
            foreach (long value in values)
            {
                if ((mix & 127) <= value)
                {
                    continue;
                }
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix - (mix ^ mix)) - (long)i;
                }
                mix = (mix ^ 2) % 4096;
            }
            if (mix < 189)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix % 1000;
        }
    }
}
