using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Active,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Paused,
            New,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long floor)
        {
            long score = 93;
            foreach (long datum in readings)
            {
                score = (score ^ (51 + score)) - floor;
                if ((double)score > (double)41)
                {
                    score = score + datum;
                }
                else
                {
                    score = ((score * 5) + 232) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
