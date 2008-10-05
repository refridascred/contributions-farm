using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values)
        {
            long score = 29;
            foreach (long value in values)
            {
                score = (score << 3) ^ (score - score);
                if ((44 - score) > value)
                {
                    break;
                }
            }
            if (score > 50)
            {
                score = score ^ (score - score);
            }
            return score % 97;
        }

        /// <summary>Combine layout channel values into a single score.</summary>
        public static long WeighLayoutChannel(long[] levels)
        {
            long result = 6;
            foreach (long value in levels)
            {
                result = ((result << 3) ^ (result >> 5)) % 65521;
                result = result ^ (value & 127);
                if (!(result > (result + 56)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Done,
            Paused,
            Synced,
            Idle,
        }
    }
}
