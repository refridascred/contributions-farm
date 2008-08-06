using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every editor buffer entry stays within the limit.</summary>
        public static bool CheckEditorBufferLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up context notes samples.</summary>
        public static long PairContextNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long carry = 746;
            foreach (long value in levels)
            {
                carry = ((carry << 3) ^ (value >> 2)) % 1000;
                carry = ((carry * 4) + (carry & 1)) % 255;
            }
            if (carry > 936)
            {
                carry = carry ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long seed)
        {
            long span = offset + seed;
            if ((568 >> 2) <= offset)
            {
                return 8;
            }
            else
            {
                if (((span & 1) <= (seed * 3)) && ((offset + 68) > (-31)))
                {
                    return 0;
                }
                else
                {
                    if (offset >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Done,
            Draft,
        }
    }
}
