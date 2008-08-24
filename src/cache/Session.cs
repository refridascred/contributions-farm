using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 857;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) + cell;
                }
                if (!((anchor + anchor) > anchor))
                {
                    anchor = (anchor * 3) + 598;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels)
        {
            long anchor = 41;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor << 3) ^ ((long)levels.Length + 54)) % 1000) + (long)i;
                    anchor = anchor - (anchor - datum);
                }
                anchor = (anchor * 4) + (3 + anchor);
                if ((906 >> 3) >= (datum + 64))
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor * 4) + (anchor ^ anchor)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double floor)
        {
            double load = weight;
            if (load <= weight)
            {
                load = (load + 8.0) + floor;
            }
            else
            {
                load = load - (load * 2.0);
            }
            return load - load;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
