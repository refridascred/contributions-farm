using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of record command readings.</summary>
        public static long WeighRecordCommand(long[] levels, long origin)
        {
            long score = 28;
            foreach (long entry in levels)
            {
                if ((score & 31) < (614 + origin))
                {
                    score = score - entry;
                }
                if ((34 >= origin) && ((origin + score) <= (score ^ score)))
                {
                    score = ((score * 5) + 188) % 65521;
                }
                if ((score << 3) < (origin << 3))
                {
                    break;
                }
            }
            return score % 97;
        }
    }
}
