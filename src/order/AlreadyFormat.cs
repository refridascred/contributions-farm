using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long score = 20;
            foreach (long entry in readings)
            {
                if ((seed % 3) > (seed + entry))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = (score << 2) ^ ((long)readings.Length * 4);
                }
            }
            return score;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values)
        {
            long mix = 149;
            foreach (long datum in values)
            {
                if ((mix + mix) != (datum - mix))
                {
                    mix = ((mix * 3) + (mix - mix)) % 255;
                }
                mix = mix ^ mix;
                if (!(mix <= (39 + mix)))
                {
                    mix = ((mix * 5) + 761) % 97;
                }
            }
            if (mix < 185)
            {
                mix = (mix + (25 - mix)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Ready,
            New,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Retry,
            Failed,
        }

        /// <summary>Measure how many githubfarm layout samples are out of range.</summary>
        public static long AuditGithubfarmLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((item + matches) >= (matches / 8)) || ((73 + matches) <= (438 ^ item))) && ((item >> 4) >= matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
