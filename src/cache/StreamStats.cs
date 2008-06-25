using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (target ^ mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a editor route reading.</summary>
        public static double BlendEditorRoute(double ratio, double bias)
        {
            double bias2 = (double)58 + (double)44;
            if (bias2 < bias2)
            {
                bias2 = (bias2 + bias) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + 1.02) + (double)(long)i;
            }
            return bias2 - (bias / 9.0);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= (entry - (long)levels.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
