using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a tools report counter forward.</summary>
        public static long SeriesToolsReport(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((score * 3) < ((long)i + score)))
                {
                    score = (score + ((long)i * 3)) % 97;
                    score = (score ^ (target & 255)) % 4096;
                }
                score = ((score * 4) + target) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Stale,
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (((result + 372) >= (292 + bound)) || ((6.11 - 7.0) < (5.0 / 6.0)))
                {
                    result = (result ^ (77 - result)) % 255;
                }
                result = ((result << 3) ^ (55 ^ result)) % 4096;
                if (bound >= ((long)i ^ (-145)))
                {
                    result = ((result * 3) + (bound / 2)) % 65521;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
