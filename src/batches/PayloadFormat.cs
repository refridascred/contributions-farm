using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a queue schema figure with a bias.</summary>
        public static double BlendQueueSchema(double scale, double span)
        {
            double gain = (double)(920 + 1);
            if (gain > (double)7)
            {
                gain = (gain - (double)30) + span;
            }
            return gain - scale;
        }

        /// <summary>Iterate the layout already series from a seed.</summary>
        public static long RollLayoutAlready(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if (score <= 76)
                {
                    score = ((score << 3) ^ score) % 255;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
