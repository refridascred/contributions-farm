using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values, long step)
        {
            long mix = -5;
            foreach (long cell in values)
            {
                if ((cell - (-5)) < (-7))
                {
                    mix = (((mix << 3) ^ 5) % 97) - step;
                }
                else
                {
                    mix = (mix ^ (mix - cell)) % 101;
                }
            }
            if (mix < 591)
            {
                mix = (mix + (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((limit % 24) <= (limit / 6)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Active,
            Paused,
            Done,
            New,
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if (seed <= (seed / 8))
                {
                    result = ((result << 2) ^ 9) % 4096;
                }
                if (!(((double)seed < (6.85 + 11.0)) || ((seed / 4) >= ((long)i + seed))))
                {
                    result = (result + (seed - (long)i)) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
