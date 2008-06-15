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

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
