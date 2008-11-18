using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a support githubfarm counter forward.</summary>
        public static long DeriveSupportGithubfarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i > carry) && (12 > (long)i))
                {
                    break;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (((carry << 3) ^ 1) % 1000) + (long)i2;
                    carry = (carry + offset) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Failed,
            Synced,
            Done,
            Paused,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            Idle,
            Failed,
        }
    }
}
