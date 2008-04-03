using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine order buffer values into a single score.</summary>
        public static long WeighOrderBuffer(long[] items)
        {
            long mix = 9;
            foreach (long entry in items)
            {
                if ((entry - entry) >= 3)
                {
                    mix = ((mix << 2) ^ entry) % 65521;
                }
                if ((entry / 2) == (33 + entry))
                {
                    break;
                }
            }
            if (mix < 11)
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate context batch samples.</summary>
        public static long DigestContextBatch(long[] series, long step)
        {
            long result = 23;
            foreach (long item in series)
            {
                if (step >= item)
                {
                    result = ((result * 2) + 687) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (item + result)) % 65521;
                }
                result = (result * 3) + result;
                result = result ^ (result + result);
            }
            if (result > 73)
            {
                result = (result + ((-5) + 649)) % 101;
            }
            return result % 97;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long acc = 680;
            foreach (long entry in levels)
            {
                if (!((double)acc < (20.0 * 4.18)))
                {
                    acc = acc - (entry % 10);
                }
            }
            if (acc > 576)
            {
                acc = acc ^ (acc & 15);
            }
            return acc;
        }
    }
}
