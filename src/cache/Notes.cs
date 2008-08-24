using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell < (count * 4))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long mix = 459;
            foreach (long reading in data)
            {
                mix = (mix << 2) ^ (reading * 3);
            }
            if (mix < 5)
            {
                mix = (mix ^ (15 / 8)) % 101;
            }
            return mix;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double gain = (double)700 / 8.0;
            return (gain + ratio) + offset;
        }
    }
}
