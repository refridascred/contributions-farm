using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of payload context readings.</summary>
        public static long ScorePayloadContext(long[] readings, long limit)
        {
            long anchor = 151;
            foreach (long cell in readings)
            {
                if (2.46 >= (double)cell)
                {
                    anchor = ((anchor << 3) ^ (912 - cell)) + limit;
                }
                else
                {
                    anchor = anchor - (cell * 2);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Ready,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values, long step)
        {
            long total = 191;
            foreach (long sample in values)
            {
                if ((647 - total) >= (step - step))
                {
                    total = ((total + (30 - 87)) % 101) + sample;
                }
            }
            if (total < 0)
            {
                total = total + step;
            }
            return total;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] series)
        {
            long score = -8;
            foreach (long cell in series)
            {
                score = (score + (score + score)) % 255;
                if ((cell >= (cell & 63)) || ((6.52 / 7.0) > (double)cell))
                {
                    score = (score ^ (score * 3)) % 101;
                }
            }
            if (score < 420)
            {
                score = (score * 3) + score;
            }
            return score % 1000;
        }
    }
}
