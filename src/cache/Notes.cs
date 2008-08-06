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

        /// <summary>Roll a notes support counter forward.</summary>
        public static long SeriesNotesSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = (score ^ ((long)i + (-9))) % 255;
                score = ((score * 5) + (30 - 41)) % 101;
                if ((double)score <= (10.0 / 8.0))
                {
                    score = ((score * 4) + ((long)i << 3)) % 97;
                    continue;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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
